## Baisc Information

This is a Database course assignment I made in 2015. 

[This is my blog link.](https://ry2an.github.io/2020/01/14/Vaccine-Making-Selling-Delivering-and-Using-System/)

[This is a video link of using the program.](https://www.bilibili.com/video/av83467024)

This project is mainly made by Visual Basic, and also use SQL grammars to operate the .mdb file, which is created by Miscrosoft Office Access.

## Background Information

In China, vaccines usually made by drug companies, bought by sellers, or CDCs. Then, CDCs would deliver vaccines to hospitals. Or hospitals would buy vaccines from sellers. The database describes this situatuion and simulates operations that may occur among the processes.

## Interfaces

![launcher](https://raw.githubusercontent.com/Ry2an/my_picture_garage/master/vacsys/launcher.PNG)

This is the window of the launcher. Please enter the testing account here.

![pview](https://raw.githubusercontent.com/Ry2an/my_picture_garage/master/vacsys/pview.png)

This is the parent page. On this page, parents can see the information of their children. System can notice parents to get vaccine based on the age of their child.

![dview](https://raw.githubusercontent.com/Ry2an/my_picture_garage/master/vacsys/dview.png)

This is the interface of doctors, where they can see basic information of themselves and their hospitals. They can also see what vaccine are their hospitals currently buying. They can also apply for new vaccine which can be notced by CDCs, sellers and drug makers.

![jview](https://raw.githubusercontent.com/Ry2an/my_picture_garage/master/vacsys/jview.png)

This is the page of CDC officers. (CDCs and Health Commissions are local and national health departmetns of China.) In this page, the officiers can see basic informations (about themselves and their deparments), add deliver, stop deliver, add application of vaccine and stop applications.

![xview](https://raw.githubusercontent.com/Ry2an/my_picture_garage/master/vacsys/xview.png)

This is the sellers' page. Selllers can add or delete orders in the market. They can also add or delete application.

![yview](https://raw.githubusercontent.com/Ry2an/my_picture_garage/master/vacsys/yview.png)

This is the page of vaccice producer. Thay can start or stop making specific vaccine. They can also add or delete application.

## Use Guide

+ Please unfold the Vacsys folder at the root of your C drive (Please make sure that the path of VaccineProductDB is "C:\VacSys\VaccineProductDB")

+ Open VacSys.exe (This is the launcher)

+ Accout that can be test are: (P: parents, D: doctors, X: sellers, J: cdc officers, Y: )
>P01
>P02
>P03
>P04
>D01
>D02
>X01
>X02
>J01
>J02
>Y01
>Y02

+ Do not make ant duplicate ID in "create request (新建交易)" and "create deliver (新建分发)"

+ Except for the launcher (VacSys.exe), do not close windows by clicking the "X" at the up right corner.

-----------------------

+ 请在解压后将VacSys文件放在C盘根目录下（确保VaccineProductDB.mdb的路径是C:\VacSys\VaccineProductDB.mdb）

+ 打开 VacSys.exe (这是登陆器)

+ 可供测试的登录帐号：
>P01
>P02
>P03
>P04
>D01
>D02
>X01
>X02
>J01
>J02
>Y01
>Y02

+ 在新建交易和新建分发是注意不要使交易编号和分发编号重复

+ 除了登录器界面外，其余界面千万不要点击右上关闭。登录器最好也是点击“退出”按钮来关闭程序。