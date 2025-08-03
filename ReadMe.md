# TaskManagerMvc 🗂️

This is a simple ASP.NET Core MVC application implementing a basic CRUD (Create, Read, Update, Delete) functionality for managing tasks.

## 📚 Technologies Used:
- C# (ASP.NET Core MVC)
- Razor Views (.cshtml)
- InMemory data storage (List<Task>)
- HTML & CSS

## 📝 Project Description:
The application demonstrates a basic CRUD interface for a Task model, including:
- Creating new tasks
- Viewing all tasks
- Editing existing tasks
- Deleting tasks

Data is stored **in memory** within the application, so all tasks will be lost when the app stops running. This is intended for learning and testing purposes.

## ⚠️ Important Usage Note:
To access the Task Manager pages, you need to append `/Task` to the base URL.

For example:  
https://localhost:5001/Task

## 🔧 How to Run the Application:
1. Clone the repository:
    ```bash
    git clone https://github.com/devdimitrijes/TaskManagerMvc.git
    ```
2. Open the project in Visual Studio.
3. Run the application using IIS Express.
4. Navigate to `https://localhost:5001/Task` (or your local port) to use the Task Manager.

## 📂 Project Structure:
Controllers/
TaskController.cs
Models/
Task.cs
Services/
TaskService.cs
Views/
Task/
Create.cshtml
Edit.cshtml
Index.cshtml
Delete.cshtml
wwwroot/
Program.cs

## 💡 What I Learned:
- Implementing CRUD operations in ASP.NET Core MVC.
- Using Dependency Injection to manage services.
- Working with in-memory data storage for simplicity.
- Understanding routing and linking in MVC.
- Basic form validation and model binding.

---

This project is intended as a learning exercise for ASP.NET Core MVC CRUD functionality and service usage.
