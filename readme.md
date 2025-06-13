# Principles Repository 🚀

Welcome to the **Principles** repository!  
This project is dedicated to exploring and implementing various software design principles and patterns, especially in the context of C# and .NET applications.


---

## 📁 Project Structure

- `Design_Patterns_ Dependency_Injection/`  
  A .NET 8.0 console app showcasing the Dependency Injection (DI) pattern:
  - **Program.cs** – Demonstrates DI by composing services, repositories, and payment processors via interfaces, not hardcoding dependencies.
  - **Entities, Interfaces, Services, Data** – Contain models (like `Product`, `Customer`), contracts, and implementations for repositories and payment logic.
  - **Example:**  
    - Create product/customer lists
    - Inject repositories and payment processors into an `OrderService`
    - Place orders with various payment methods (CreditCard, PayPal)
    - Output shows order details for each scenario  
    - 🧩 **Benefits:** Testable, extensible, and maintainable code.

- `Design_Patterns_Singleton/`  
  Code and notes for the Singleton design pattern.

- `testAppConsol.sln`  
  The main solution file for the console application.

---

## ✨ Features

- Clear, hands-on examples of popular design patterns
- Organized code and documentation for fast learning
- Ready-to-run .NET solution file for practice

---

## 🛠️ Getting Started

1. **Clone the repo**
   ```bash
   git clone https://github.com/abdoshady550/Principles.git
   ```
2. **Open the solution**  
   Open `testAppConsol.sln` in Visual Studio or your preferred .NET IDE.

3. **Explore the design patterns**  
   - Start with `Design_Patterns_ Dependency_Injection/Program.cs` to see Dependency Injection in action.
   - Check the `Entities`, `Interfaces`, and `Services` subfolders for extensible architecture.

---

## 🤝 Contributing

Contributions, suggestions, and improvements are welcome!  
Feel free to open issues or pull requests.

---

## 📬 Contact

For questions or feedback, reach out to [@abdoshady550](https://github.com/abdoshady550).  

---

Happy coding! 🎉
