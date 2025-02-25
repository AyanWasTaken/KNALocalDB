# KNA LocalDB
KNA LocalDB is a database to store data on the users computer locally in one place (for .NET). 

We have our main KNA LocalDB (LDB) for building apps, and MyKNA to edit existing values outside the app (creating new local DBs using MyKNA will be added in the future).

KNA Documentation (basic usage for all apps):

## KNA LDB (localDB)
This is the main LDB builder. Let me show you how you do it as best as I can outside the wiki.

![image](https://github.com/user-attachments/assets/6fe7d2b5-73bc-485b-810f-f44d9bc9d0af)

Make sure KNA is present in your project directory.

![image](https://github.com/user-attachments/assets/85a1d198-af3f-4064-a66d-637bd2ef8e1f)

Make sure to add a reference for KNA.dll.

![image](https://github.com/user-attachments/assets/c2ef9163-e46c-4ae9-8084-8ecff9c2d990)

Add a reference here too.

![image](https://github.com/user-attachments/assets/3874e62a-c7dc-44be-a82a-a17dbfc785ae)

This is the basic usage for the library. Simple right?

**Creating a string**



## MyKNA
Want to edit a KNA LDB outside the code? Look no further. MyKNA is built by me and will not receive any major updates as its just a tool.

*Before installing, make sure you have .NET Framework 4.8 installed.*

![image](https://github.com/user-attachments/assets/8b35e580-f1a3-4e0a-a790-fa6a5d3dfda7)

(Screenshot of MyKNA 1.0, will look different if you're using a pre-release version.)

**How to use**

Value Editor

![image](https://github.com/user-attachments/assets/a398ded8-810f-402c-8cbf-a525df9335cb)

(PRE-ALPHA VERSION 9, WILL LOOK DIFFERENT ON YOUR END.)

This is slightly complicated as MyKNA is only meant to be edited within the code of a project. Now let us teach you how to use it.
First we need to select a value to edit, press the button and select the value you want to edit like for this LDB.

![image](https://github.com/user-attachments/assets/87c0a5a0-384c-4f94-90a0-81f4c0603d16)

Select the KNA LDB version the LDB is made in.
Set the value type to string if you are using 1.0 even if you use the converted integer or booleans.

Input the new value and press save value.
Just like that, you are done.
