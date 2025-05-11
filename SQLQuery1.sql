CREATE TABLE Users (
    
	userId VARCHAR(50) PRIMARY KEY ,
    pass Varchar(50),
	full_name VARCHAR(100),
   phone_num VARCHAR(15) ,
     city varchar(20)
);

select * from Users ;
select * from Admins;

DELETE FROM Users
WHERE userId = 'sss';


 "select * from Users Where userId=' " + userId + "' and pass= '" + pass + "'";
 select * from Users where userId='saqib16' and pass='saqib123' ;


 CREATE TABLE Admins (
    
	userId VARCHAR(50) PRIMARY KEY ,
    pass Varchar(50),
	full_name VARCHAR(100)
);
insert into Admins(userId,pass,full_name) values('Admin','admin','Saqib Al Mahmud') ;