# 🖥️ System Resource Monitor

A lightweight **C# console application** to monitor **CPU**, **RAM**, and **Disk** usage in real-time with **color-coded indicators**.  
Perfect for developers, testers, and enthusiasts who want a simple way to track system performance.

---

## ✨ Features
- 📊 **Real-time monitoring** of:
  - CPU usage (%)
  - RAM availability (MB)
  - Disk activity (%)
- 🎨 **Color-coded output**:
  - 🟢 Green → Healthy
  - 🟡 Yellow → Moderate load
  - 🔴 Red → High load
- ⚡ **1-second refresh rate**
- 🛠️ Minimal dependencies

---

## 📷 Example Output

CPU: 23.4 % 🟢
RAM: 6400 MB 🟢
Disk: 12.5 % 🟢


---

## 📦 Installation
1. Clone the repository:
   git clone https://github.com/YourUsername/System-Resource-Monitor.git

2. Open the project in **Visual Studio** or any C# IDE.
3. Build and run.

---

## 🛠️ How It Works

* Uses **System.Diagnostics.PerformanceCounter** to fetch real-time system stats.
* Color changes based on defined thresholds:

  * **CPU/Disk**:

    * 🟢 ≤ 50%
    * 🟡 51–80%
    * 🔴 > 80%
  * **RAM**:

    * 🟢 ≥ 4000 MB
    * 🟡 2000–3999 MB
    * 🔴 < 2000 MB

---

## 👨‍💻 Author

**Ali Suleymanli**
📧 \suleymanliali830@gmail.com

---

## 📜 License

This project is licensed under the MIT License - feel free to use and modify.

