
use condo;
-- ------------------------------------------------
Select id_user,nome,perfil from tbl_usuario where senha = '22222222' and perfil != 'Morador' or perfil = 'Entregador';

insert into tbl_condominio(nome,rua,numero,cidade,estado,data_cad)
values('Conjunto Habitacional Embu B1','Rua sao Benedito','220','Embu das Artes','Sao Paulo',current_date);

insert into tbl_usuario (perfil,nome,apto,bloco,senha,id_biometria,data_cad,user_logado)
values
       ('Admin','Romario admin','','','r3o4m3s6','1',current_date,1);

-- ------------------------------------------------------------------------------------
insert into tbl_unidades(id_user,apto,bloco) Values    
(1,'Ap 01','Bl 01'), 
(1,'Ap 11','Bl 01'),
(1,'Ap 21','Bl 01'),
(1,'Ap 31','Bl 01'),
(1,'Ap 02','Bl 01'),
(1,'Ap 12','Bl 01'),
(1,'Ap 22','Bl 01'),
(1,'Ap 32','Bl 01'),
(1,'Ap 01','Bl 02'), 
(1,'Ap 11','Bl 02'),
(1,'Ap 21','Bl 02'),
(4,'Ap 31','Bl 02'),
(4,'Ap 02','Bl 02'),
(1,'Ap 12','Bl 02'),
(4,'Ap 22','Bl 02'),
(2,'Ap 32','Bl 02'),
(5,'Ap 01','Bl 03'), 
(3,'Ap 11','Bl 03'),
(3,'Ap 21','Bl 03'),
(1,'Ap 31','Bl 03'),
(5,'Ap 02','Bl 03'),
(4,'Ap 12','Bl 03'),
(3,'Ap 22','Bl 03'),
(1,'Ap 32','Bl 03'),
(2,'Ap 01','Bl 04'), 
(4,'Ap 11','Bl 04'),
(5,'Ap 21','Bl 04'),
(3,'Ap 31','Bl 04'),
(1,'Ap 02','Bl 04'),
(2,'Ap 12','Bl 04'),
(3,'Ap 22','Bl 04'),
(4,'Ap 32','Bl 04'),
(5,'Ap 01','Bl 05'), 
(3,'Ap 11','Bl 05'),
(2,'Ap 21','Bl 05'),
(4,'Ap 31','Bl 05'),
(5,'Ap 02','Bl 05'),
(1,'Ap 12','Bl 05'),
(2,'Ap 22','Bl 05'),
(4,'Ap 32','Bl 05');


insert into tbl_ebox(id_user,num_ebox,tamanho,status_ebox,data_cad)
values
(1,'EBXP01','Pequeno','Livre',current_date),
(1,'EBXP02','Pequeno','Livre',current_date),
(1,'EBXP03','Pequeno','Livre',current_date),
(1,'EBXP04','Pequeno','Livre',current_date),
(1,'EBXP05','Pequeno','Livre',current_date),
(1,'EBXP06','Pequeno','Livre',current_date),
(1,'EBXP07','Pequeno','Livre',current_date),
(1,'EBXP08','Pequeno','Livre',current_date),
(4,'EBXP09','Pequeno','Livre',current_date),
(4,'EBXP10','Pequeno','Livre',current_date),
(5,'EBXM01','Medio','Livre',current_date),
(5,'EBXM02','Medio','Livre',current_date),
(1,'EBXM03','Medio','Livre',current_date),
(3,'EBXM04','Medio','Livre',current_date),
(5,'EBXM05','Medio','Livre',current_date),
(4,'EBXM06','Medio','Livre',current_date),
(2,'EBXM07','Medio','Livre',current_date),
(1,'EBXM08','Medio','Livre',current_date),
(5,'EBXM09','Medio','Livre',current_date),
(5,'EBXM10','Medio','Livre',current_date),
(1,'EBXG01','Grande','Livre',current_date),
(2,'EBXG02','Grande','Livre',current_date),
(2,'EBXG03','Grande','Livre',current_date),
(1,'EBXG04','Grande','Livre',current_date),
(4,'EBXG05','Grande','Livre',current_date),
(4,'EBXG06','Grande','Livre',current_date),
(3,'EBXG07','Grande','Livre',current_date),
(3,'EBXG08','Grande','Livre',current_date),
(2,'EBXG09','Grande','Livre',current_date),
(2,'EBXG10','Grande','Livre',current_date);

-- -----------------------------------------------------------------------------------accessible

insert into tbl_inclusao_ebox(id_user,id_ebox,num_encomenda,peso,apto,bloco,comentario,data_inclusao,data_retirada)
values
(1,1,'DXB70935BR','0,750','Ap 01','Bl 01','Pacote plastico',current_date,'2017-10-31'),
(3,3,'OAB72938BR','0,250','Ap 12','Bl 02','--',current_date,'2017-10-31'),
(5,10,'RRB88935BR','0,750','Ap 31','Bl 02','--',current_date,'2017-10-31'),
(2,11,'OAB72225BR','0,850','Ap 21','Bl 01','Produto atrasado',current_date,'2017-10-31'),
(4,5,'pAB71111BR','0,750','Ap 22','Bl 04','embalagem violada',current_date,'2017-10-31'),
(3,13,'OAB77897BR','0,150','Ap 21','Bl 05','etiqueta apagada',current_date,'2017-10-31'),
(5,7,'DAB32655BR','0,750','Ap 01','Bl 05','--',current_date,'2017-10-31'),
(1,4,'OAB76905BR','0,350','Ap 22','Bl 03','rasgo',current_date,'2017-10-31'),
(2,9,'ODB12765BR','0,750','Ap 12','Bl 04','pacote grande',current_date,'2017-10-31'),
(3,14,'OPB70935BR','0,50','Ap 11','Bl 05','-',current_date,'2017-10-31');

-- ---------------------------------------------------------------------------------------------------

insert into tbl_retirada_ebox(id_inclusao,id_user,id_ebox,data_retirada)
values(1,1,1,'currente_date');

-- ------------------------------------------------------------------------------------

insert into tbl_manutencao(id_login,id_ebox,desc_falha,data_falha,data_conserto,comentario)
values (1,1,'Porta emperrada','2017-10-21','2017-10-25','Trocado fechadura');

Select id_inclusao as Codigo,id_ebox as Compartimento,num_encomenda,apto,bloco,data_inclusao,data_retirada from tbl_inclusao_ebox where processo = 'Em andamento'

SELECT n.id_inclusao,n.num_encomenda,e.id_ebox,e.num_ebox
FROM tbl_inclusao_ebox AS n
INNER JOIN tbl_ebox AS e
ON n.id_inclusao = e.id_ebox
INNER JOIN tbl_editoras AS E
ON L.ID_editora = E.ID_editora
WHERE E.Nome_Editora LIKE 'O%'
ORDER BY L.Preco_Livro DESC;

SELECT n.id_inclusao,n.num_encomenda,n.id_ebox,e.num_ebox
FROM tbl_inclusao_ebox AS n
INNER JOIN tbl_ebox AS e
ON n.id_inclusao = e.id_ebox
WHERE n.id_Inclusao = 2 and n.apto  LIKE 'Apartamento 02' and n.bloco LIKE 'bloco 02'


delimiter $
create procedure pcd_ebox( id int ,apto varchar(20),bloco varchar(20) )

begin
SELECT n.id_inclusao,n.num_encomenda,n.id_ebox,e.num_ebox
FROM tbl_inclusao_ebox AS n
INNER JOIN tbl_ebox AS e
ON n.id_inclusao = e.id_ebox
WHERE n.id_Inclusao = id and n.apto  LIKE apto and n.bloco LIKE bloco;

end;
$
call pcd_ebox( 2,'apartamento 02','bloco 02' )
$
select num_encomenda from tbl_inclusao_ebox where apto = 'apartamento 02' and bloco = 'bloco 02';
 SELECT MAX(id_ebox) FROM tbl_ebox
SELECT num_ebox FROM tbl_ebox where id_ebox = 1
SELECT status_ebox FROM tbl_ebox where id_ebox = 5
SELECT tbl_inclusao_ebox.id_inclusao,tbl_inclusao_ebox.num_encomenda,tbl_ebox.id_ebox,
tbl_ebox.num_ebox FROM tbl_inclusao_ebox INNER JOIN tbl_ebox  ON tbl_inclusao_ebox.id_inclusao = tbl_ebox.id_ebox
WHERE tbl_inclusao_ebox.apto = 'apartamento 02' and tbl_inclusao_ebox.bloco = 'bloco 02' ;

SELECT distinct bloco from tbl_unidades group by bloco;

select num_ebox,id_os_aberto from tbl_ebox inner join tbl_os_aberto where tbl_ebox.id_ebox = tbl_os_aberto.id_ebox and status_os = 'Em aberto';

select tbl_os_aberto.id_os_aberto as Codigo,tbl_ebox.num_ebox as Ebox ,tbl_os_aberto.Motivo,tbl_os_aberto.Data_ocorrencia,tbl_usuario.nome as Responsavel from tbl_ebox inner join tbl_os_aberto inner join tbl_usuario  where tbl_ebox.id_ebox = tbl_os_aberto.id_ebox and tbl_os_aberto.id_user = tbl_usuario.id_user and status_os = 'Em aberto';

select o.id_os_aberto as Codigo,e.num_ebox as Ebox ,o.Motivo,o.Data_ocorrencia,u.nome as Responsavel from tbl_ebox e inner join tbl_os_aberto o inner join tbl_usuario u where e.id_ebox = o.id_ebox and o.id_user = u.id_user and o.status_os = 'Em aberto';



     select f.id_os_fechado as Codigo,o.id_os_aberto as Ocorrencia,e.num_ebox as Ebox ,o.Motivo,o.Data_cad as Data_bloqueio,
     f.data_cad as Data_desbloqueio,f.Empresa,f.responsavel as Responsavel from tbl_ebox e inner join tbl_os_aberto o inner join tbl_os_fechado f
     where e.id_ebox = o.id_ebox and f.id_os_fechado = o.id_os_aberto;


  