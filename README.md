# knowledge-test
*This project was completed as a course work in the discipline of Object-Oriented Programming.
The task was to create 100 practice tests for Chapter 8, "More on Methods and Classes," of Herbert Schildt's book C# 4.0: The Complete Guide.
The app turned out to be flexible enough to be filled with any kind of tests, not just programming.*
An app that can be filled out with a variety of single-choice tests. 

A C# window application using Windows Forms, in which you can add a fairly large number of tests and test the knowledge of users. 

I set myself the task of developing a program with the following functions:

- Register users in the application, add information to the database;
- The test tasks should be stored in the database to ensure minimal security, and it is much more convenient than storing data directly inside the application;
- Make it easy to regulate how many random tests out of N will be given for passing;
- As an additional feature, add a competition system in the form of displaying the top 5 users with the highest number of points before and after the test;
- A fixed time should be allocated for each task;
- Implement sending detailed test results to the user's email address, which he or she will enter during registration.


--------------------------------------------------------


Віконний додаток на мові C# з використанням Windows Forms, у який можна буде додавати досить велику кількість тестів та перевірити знання користувачів. 

Перед собою я поставив завдання розробити програму з наступними функціями:
-	Реєстрація користувачів у додатку, додавання інформацію у базу даних;
-	Завдання тесту мають зберігатись у базі даних для забезпечення мінімальної безпеки, до того ж це набагато зручніше, аніж зберігати дані безпосередньо всередині додатку;
-	Зробити зручне регулювання, яка кількість рандомних тестів з N буде даватись для проходження;
-	У вигляді додаткової функції, додати систему конкуренції у вигляді виводу топ 5 користувачів з найбільшою кількістю набраних балів до проходження тесту і після;
-	На кожне завдання має бути виділено фіксований час;
-	Реалізувати відправлення детальних результатів тестування на пошту користувачеві, яку він відповідно впише при реєстрації.

--------------------------------------------------------
The application consists of 6 windows:
1) First

![image](https://github.com/vladyslav-keidaliuk/knowledge-test/assets/102413334/71f8538c-e9e6-4e2c-a778-363ab4a0ee17)

2) User registration

![image](https://github.com/vladyslav-keidaliuk/knowledge-test/assets/102413334/26642cb8-b206-4508-8e49-88f04fc872c2)

3) User authorization

![image](https://github.com/vladyslav-keidaliuk/knowledge-test/assets/102413334/fdc952a3-69dd-4b6e-a22a-d0817607f225)

4) Window after authorization

![image](https://github.com/vladyslav-keidaliuk/knowledge-test/assets/102413334/25e297f8-c691-4e2c-b90d-d56794503d1c)

5) Window with test

![image](https://github.com/vladyslav-keidaliuk/knowledge-test/assets/102413334/bced99e4-aae6-46e0-9e5b-8f9f625ef7ed)

6) Window with results

![image](https://github.com/vladyslav-keidaliuk/knowledge-test/assets/102413334/357484cb-a273-4b9e-a2b6-1e1ea644c6d6)

Features of the application :
- Saving user data and their test results in MySQL database
- Test tasks are stored in the MySQL database
- Sending detailed test results to the user's mail, which he specified during registration (only Gmail mail is allowed)
- A fixed time is allocated for the task, if the time expires, the application will switch to the next task

