go
if OBJECT_ID(N'TEACHER','u')is not null
drop table TEACHER
GO
create table TEACHER
(
Teacher_id int identity(1,1) primary key,
T_name nvarchar(200) not null,
T_surename nvarchar(200) not null,
Gender nvarchar(10) not null,
Subject nvarchar(50) not null,)
Insert into TEACHER values (N'გიორგი',N'ბერიძე ','male',N'მათემატიკა');
Insert into TEACHER values (N'მაგდა',N'თათრიშვილი','female',N'სპორტი');
Insert into TEACHER values (N'გოგა',N' ჭავჭავაძე ','male',N'ისტორია');
Insert into TEACHER values (N'გიორგი ',N' თოდუა','male',N'გეოგრაფია');
Insert into TEACHER values (N'მაია',N'ჩუბინიძე','female',N'ბიოლოგია');
Insert into TEACHER values (N'ელენე ',N'კვანტალია','female',N'ქიმია');
Insert into TEACHER values (N'ნინო',N'პაშალიშვილი ','female',N'ფიზიკა');
Insert into TEACHER values (N'ნინო',N'გოგალძე','female',N'ქიმია');



go
if OBJECT_ID(N'PUPIL','u')is not null
drop table PUPIL
GO
create table PUPIL
(
Pupil_id int identity(1,1) primary key,
Name nvarchar(200) not null,
Surename nvarchar(200) not null,
Gender nvarchar(10) not null,
Class nvarchar(50) not null,
)
Insert into PUPIL  (Name,Surename,Gender,Class) values (N'ლაშა',N'ბაშარული ','female','9');
Insert into PUPIL  (Name,Surename,Gender,Class) values  (N'გიორგი',N'კულუხოვი','female','11');
Insert into PUPIL  (Name,Surename,Gender,Class) values  (N'ეკა',N'ფრუიძე ','male','6');
Insert into PUPIL  (Name,Surename,Gender,Class) values  (N'გვანცა ',N'ქანთარია','female','6');
 Insert into PUPIL  (Name,Surename,Gender,Class) values (N'ჯუნა',N'მაისურიძე','female','8');
 Insert into PUPIL  (Name,Surename,Gender,Class) values (N'ნორა',N'ანდრიაძე ','female','12');
 Insert into PUPIL  (Name,Surename,Gender,Class) values (N'გიორგი',N'გოგიძე','male','6');
Insert into PUPIL  (Name,Surename,Gender,Class) values  (N'ნინო',N'შარვაძე','female','7');


go
if OBJECT_ID(N'LESSON','u')is not null
drop table LESSON
GO
create table LESSON
(
Lesson_id int identity(1,1) primary key,
Teacher_id int foreign key references TEACHER(Teacher_id) on delete cascade on update cascade NOT NULL,
Pupil_id int foreign key references PUPIL(Pupil_id) on delete cascade on update cascade NOT NULL,

)

select [T_name],[T_surename],[Subject]
from [dbo].[TEACHER]
where T_name = 'გიორგი'