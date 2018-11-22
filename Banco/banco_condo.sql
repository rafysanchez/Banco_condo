 create database condo;

use condo;

#///////////////////////////////////////////////////////////////////////////////////

create table if not exists tbl_condominio(
id_condo int not null auto_increment,
nome varchar(30) not null,
rua varchar(30) not null,
numero varchar(5) not null,
cidade varchar(45) not null,
estado varchar(45) not null,
data_cad date,
constraint pk_condo primary key(id_condo)
);

create table if not exists tbl_usuario(
id_user int not null auto_increment,
nome varchar(30) not null,
perfil varchar(20)not null,
apto varchar(20) not null,
bloco varchar(20) not  null,
senha char(8) not null,
id_biometria int,
data_cad date,
user_logado int not null,
constraint  pk_id_user primary key(id_user));

insert into tbl_usuario (perfil,nome,apto,bloco,senha,id_biometria,data_cad,user_logado)
values
       ('Admin','Administrador','','','12345678','1',current_date,1);

create table if not exists tbl_unidades(
id_unidades int not null auto_increment,
id_user int not null,
apto varchar(10)not null,
bloco varchar(10)not null,
 primary key(id_unidades),
FOREIGN KEY(id_user) REFERENCES tbl_usuario (id_user));

create table if not exists tbl_ebox(
id_ebox int not null auto_increment,
id_user int not null,
num_ebox char(10) not null,
tamanho varchar(10) not null,
status_ebox varchar(20) not null,
data_cad date not null,
constraint  pk_ebox primary key(id_ebox),
CONSTRAINT fk_ebox FOREIGN KEY(id_user) REFERENCES tbl_usuario (id_user)
);

create table if not exists tbl_inclusao_ebox(
id_inclusao int not null auto_increment,
id_user int not null,
id_ebox int not null,
num_encomenda varchar(20) not null,
apto varchar(20) not null,
bloco varchar(20) not null,
comentario varchar(100) ,
data_inclusao date,
data_retirada date not null,
status_retirada varchar(20) not null default 'Em processo',
processo varchar(20) not null default 'Em andamento',
CONSTRAINT pk_Iebox PRIMARY KEY(id_inclusao),
CONSTRAINT fk_Iebox FOREIGN KEY(id_user) REFERENCES tbl_usuario (id_user),
CONSTRAINT fk_Ieboxx FOREIGN KEY(id_ebox) REFERENCES tbl_ebox (id_ebox)
);

create table if not exists tbl_retirada_ebox(
id_retirada int not null auto_increment,
id_inclusao int not null ,
id_user int not null,
id_ebox int not null,
data_retirada date,
CONSTRAINT pk_rebx PRIMARY KEY(id_retirada),
CONSTRAINT fk_rebo FOREIGN KEY(id_inclusao) REFERENCES tbl_inclusao_ebox (id_inclusao),
CONSTRAINT fk_rebox FOREIGN KEY(id_user) REFERENCES tbl_usuario (id_user),
CONSTRAINT fk_reboxx FOREIGN KEY(id_ebox) REFERENCES tbl_ebox (id_ebox)
);

create table if not exists tbl_os_aberto(
id_os_aberto int not null auto_increment,
id_user int not null,
id_ebox int not null,
motivo varchar(100) not null,
data_ocorrencia date,
data_cad date,
status_os varchar(10) default 'Em aberto',
CONSTRAINT pk_os PRIMARY KEY(id_os_aberto),
CONSTRAINT fk_osUser FOREIGN KEY(id_user) REFERENCES tbl_usuario (id_user),
CONSTRAINT fk_osEbox FOREIGN KEY(id_ebox) REFERENCES tbl_ebox (id_ebox)
);

create table if not exists tbl_os_fechado(
id_os_fechado int not null auto_increment,
id_os_aberto int not null,
id_user int not null,
id_ebox int not null,
empresa varchar(40) not null,
responsavel varchar(40) not null,
comentario varchar(100) not null,
data_conclusao date,
data_cad date,
CONSTRAINT pk_osfechado PRIMARY KEY(id_os_fechado),
CONSTRAINT fk_osfechado2 FOREIGN KEY(id_user) REFERENCES tbl_usuario (id_user),
CONSTRAINT fk_osFecado FOREIGN KEY(id_ebox) REFERENCES tbl_ebox (id_ebox),
CONSTRAINT fk_osFecdo FOREIGN KEY(id_os_aberto) REFERENCES tbl_os_aberto(id_os_aberto)
);

create table if not exists tbl_log_conexao(
id_log int not null auto_increment,
log_acao varchar(10) not null,
data_log date,
hora_log time,
constraint pk primary key (id_log)
);

create table if not exists tbl_log_abertura(
id_log_abertura int not null auto_increment,
id_user int not null,
ebox varchar(20) not null,
motivo varchar(100) not null,
data_log date,
hora_log time,
constraint pk primary key (id_log_abertura),
CONSTRAINT fk_id FOREIGN KEY(id_user) REFERENCES tbl_usuario (id_user)
);

create table if not exists tbl_backup(
id_backup int not null auto_increment,
id_user int not null ,
local_bd varchar(200) not null,
freq_backup varchar(100)not null,
local_backup varchar(200) not null,
constraint  pk_id_backup primary key(id_backup),
FOREIGN KEY(id_user) REFERENCES tbl_usuario (id_user));


create table if not exists tbl_restore(
id_restore int not null auto_increment,
id_user int not null ,
usuario varchar(45) not null,
local_restore varchar(200) not null,
data_restore date, 
hora_restore time ,
constraint  pk_id_restore primary key(id_restore),
FOREIGN KEY(id_user) REFERENCES tbl_usuario (id_user));

## TRIGER PARA ATUALIZAR EBOX APOS INCLUSAO ENCOMENDA

delimiter $
create  trigger trg_update_ebox after insert on tbl_inclusao_ebox 
for each row
begin
update tbl_ebox set status_ebox = 'Ocupado' where id_ebox = 
(select id_ebox from tbl_inclusao_ebox where id_inclusao = (select max(id_inclusao)from tbl_inclusao_ebox));
end
$

## TRIGER PARA ATUALIZAR EBOX APOS Retirada ENCOMENDA

delimiter $
create trigger trg_update_Retirada_ebox after insert on tbl_retirada_ebox 
for each row
begin
update tbl_ebox set status_ebox = 'Livre' where id_ebox = 
(select id_ebox from tbl_retirada_ebox where id_retirada = (select max(id_retirada)from tbl_retirada_ebox));

update tbl_inclusao_ebox set processo = 'Concluido' where id_inclusao = 
(select id_inclusao from tbl_retirada_ebox where id_retirada = (select max(id_retirada)from tbl_retirada_ebox));
end
$

## PROCEDURE PARA VERIFICAR SE TEMPO DE RETIADA ULTRAPASSOU

delimiter $
create procedure pcd_update_data( id int )

begin
if ( select date(current_date) >
   (select data_retirada from tbl_inclusao_ebox where id_inclusao = id 
   and processo = 'Em andamento'))
then
Update tbl_ebox set status_ebox = 'Ocupado/Atraso' where id_ebox = id;
Update tbl_inclusao_ebox set status_retirada = 'Em atraso' where id_inclusao = id;
end if;
end;
$
call pcd_update_data( 3 )
$

## TRIGER PARA ATUALIZAR EBOX APOS BLOQUEIO

delimiter $
create trigger trg_update_bloqueio_ebox after insert on tbl_os_aberto 
for each row
begin
update tbl_ebox set status_ebox = 'Bloqueado' where id_ebox = 
(select id_ebox from tbl_os_aberto where id_os_aberto = (select max(id_os_aberto)from tbl_os_aberto));

end
$

## TRIGER PARA ATUALIZAR EBOX APOS DESBLOQUEIO

delimiter $
create trigger trg_update_desbloqueio_ebox after insert on tbl_os_fechado 
for each row
begin
update tbl_ebox set status_ebox = 'Livre' where id_ebox = 
(select id_ebox from tbl_os_fechado where id_os_fechado = (select max(id_os_fechado)from tbl_os_fechado));

update tbl_os_aberto set status_os = 'Concluido' where id_os_aberto = 
(select id_os_aberto from tbl_os_fechado where id_os_fechado = (select max(id_os_fechado)from tbl_os_fechado));
end
$