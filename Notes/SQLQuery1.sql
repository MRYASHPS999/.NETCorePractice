SELECT TOP (1000) [userid]
      ,[username]
      ,[Email]
      ,[passowrd]
      ,[userrole]
  FROM [junbatchcodefirst].[dbo].[userlogin]




truncate table userlogin;

update userlogin set passowrd='admin456' where userid=2;

insert into userlogin values('Test','test@test.com','123456','User');
insert into userlogin values('Admin','admin@test.com','admin123','Admin');
insert into userlogin values('Admin1','admin1@test.com','Admin123','Admin');
insert into userlogin values('John','john@gmail.com','john123','User');
insert into userlogin values('meet','meet@test.com','meet123','User');
