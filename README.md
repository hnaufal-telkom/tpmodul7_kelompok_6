# Student Data & Courses Parser 🚀📚

A C# Console Application to parse student data and courses from JSON files. Built with ❤️ for Module 7 Assignment!

---

## ✨ Features

### 📌 Student Data Parser  
Reads a JSON file containing student information and displays it in a human-friendly format.  
**Example Output:**  
`Nama Cecep Wonderland dengan NIM 1234567890 dari fakultas Informatika`

### 📌 Courses Parser  
Parses a JSON file of enrolled courses and prints a neatly formatted list.  
**Example Output:**
```
Daftar mata kuliah yang diambil:
MK 1 CS101 - Introduction to Programming
MK 2 DS202 - Data Structures
```

---

## 🛠️ Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/hnaufal-telkom/tpmodul7_kelompok_6.git
   cd tpmodul7_kelompok_x
   ```

2. **Switch to your branch**
   ```bash
   git checkout your_branch_name
   ```

3. **Open the project in Visual Studio (or your favorite IDE)**  
   - Open the `.csproj` file.
   - Restore NuGet packages if necessary.

---

## 🚦 Usage

### ▶️ Parsing Student Data (`DataMahasiswa`)
1. Place your JSON file named `tp7_1_<NIM>.json` in the project root directory.
2. Run the following code in your `Main` method:
   ```csharp
   DataMahasiswa1234567890 data = new DataMahasiswa1234567890();
   data.ReadJSON();
   ```

### ▶️ Parsing Courses (`KuliahMahasiswa`)
1. Place your JSON file named `tp7_2_<NIM>.json` in the project root directory.
2. Run the following code in your `Main` method:
   ```csharp
   KuliahMahasiswa1234567890 courses = new KuliahMahasiswa1234567890();
   courses.ReadJSON();
   ```

---

## 🧩 Code Overview

### 🧾 Classes

- **`DataMahasiswa`**
  - Deserializes student data from a JSON file.
  - Uses the nested `Nama` class for separating first and last names.
  - Implements error handling for missing files and malformed JSON.

- **`KuliahMahasiswa`**
  - Parses an array of course data from a JSON file.
  - Handles cases when no courses are present.
  - Includes robust error handling.

### 📁 Example JSON Structures

#### For Student Data
```json
{
  "nama": {
    "depan": "Cecep",
    "belakang": "Wonderland"
  },
  "nim": "1234567890",
  "fakultas": "Informatika"
}
```

#### For Course List
```json
{
  "courses": [
    { "code": "CS101", "name": "Introduction to Programming" },
    { "code": "DS202", "name": "Data Structures" }
  ]
}
```

---

## 👥 Team

- **Cecep Lizard** (1234567890) – *JSON Wizard* 🧙‍♀️  
- **Bob FrontEnd** (1234567890) – *Git Master* 🐙

Project for **University of Awesome – Module 7 Assignment**

---

## 📜 License

MIT License – Feel free to fork, modify, and use!

What this license is actually for 😂

---
