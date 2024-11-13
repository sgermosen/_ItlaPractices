create database MyDatabase;

use MyDatabase;

drop database MyDatabase;


--short comment
/*
this is a
long comments
*/

create table Contacts (
Id int identity (1,1), --primary key
Name varchar(25) not null, 
LastName varchar(25) not null, 
Address  varchar(250) not null, 
Email  varchar(50) not null, 
Gender  char(1) not null, 
Age  int not null, 
deleteme int ,
--IsFavorite  bit not null 
)

drop table Contacts;

alter table Contacts
add   IsFavorite int not null;

ALTER TABLE  Contacts ADD CONSTRAINT
    PK_Contacts PRIMARY KEY  
    (
    Id
    )   ON [PRIMARY]

	alter table Contacts
drop column  deleteme  ;

	alter table Contacts 
	alter column IsFavorite bit not null;

	---
	insert Contacts (Name,   LastName,     Address,    Email,             Gender,  Age,IsFavorite) values 
	                ('AlbertJuan','Echhavarria','Calle PArcha', 'email@email.com', 'M',   15, 'true' );

						insert Contacts (Name,   LastName,     Address,    Email,             Gender,  Age,IsFavorite) values 
	                ('Juana','montas','Calle PArcha', 'email@email.com', 'M',   15, 'true' );
						insert Contacts (Name,   LastName,     Address,    Email,             Gender,  Age,IsFavorite) values 
	                ('Juancito','perez','Calle PArcha', 'email@email.com', 'M',   15, 'true' );
						insert Contacts (Name,   LastName,     Address,    Email,             Gender,  Age,IsFavorite) values 
	                ('Juaniquito','masiel','Calle PArcha', 'email@email.com', 'M',   15, 'true' );
select * from Contacts;

select Name, LastName  from Contacts;

begin transaction ;

update Contacts set Address='Callle soleada bonita', Email='pruebax@email.com'
where id=3

update Contacts set isfavorite = 1
where id=3

rollback

commit

delete from Contacts where id=7

select Name, LastName, isfavorite  from Contacts
where name like '%juan' and  isfavorite=1
;