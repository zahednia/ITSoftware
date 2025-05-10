# 🖥️ IT Hardware & Maintenance System

A complete desktop application for managing computer hardware, user assignments, periodic timesheets, and technical inspections in an IT infrastructure. Built with WinForms, Entity Framework Core, and SQL Server.

---

## 📌 Features

- ✅ Manage hardware types: CPU, RAM, HDD, SSD, GPU, Motherboard  
- ✅ Support for **multiple HDDs/SSDs per system** with dynamic ComboBox UI  
- ✅ Assign users to computers and track **user assignment history**  
- ✅ Record **checklists** for physical inspections  
- ✅ Generate and manage **periodic timesheets**  
- ✅ Auto-mark `IsDone = true` when a checklist is registered ±15 days around a visit  
- ✅ Clone all timesheets from one year (e.g., 1404) to the next (e.g., 1405) with date shift  
- ✅ Toast notifications for **upcoming due systems**  
- ✅ Persian calendar support with automatic date conversion  
- ✅ Responsive UI and validation with meaningful error handling  

---

## 🛠️ Tech Stack

- **.NET 6** or **.NET Framework 4.8**  
- **WinForms**  
- **Entity Framework Core**  
- **SQL Server**  
- `CommunityToolkit.WinUI.Notifications`  
- `System.Globalization.PersianCalendar`  

---

## 🧰 Prerequisites

- Visual Studio 2022+  
- .NET 6 SDK (or install .NET Framework 4.8 if targeting it)  
- SQL Server or LocalDB  
- Git  

---

## ⚙️ Setup Instructions

### 1. Clone the repository

```bash
git clone https://github.com/zahednia/ITSoftware
cd it-hardware-checkup

```
### 📦 3. Run database migrations

You can apply Entity Framework migrations to set up the database schema.

#### Via Visual Studio Package Manager Console:

```powershell
Update-Database
```

### ▶️ 4. Run the Project

Open the solution file `ITSoftware.sln` in Visual Studio.

Then:

1. Build the project (`Ctrl + Shift + B`)
2. Run the application (`F5` or click **Start**)

Once launched, the main application window allows access to the following modules:

- 🖥️ **Computer List & User Assignment**  
  View, edit, and assign users to systems, track history of ownership

- 🛠️ **Hardware Management**  
  Add/edit components (CPU, RAM, HDD, SSD, etc.) with support for multiple instances per system

- 📋 **Checklist Panel**  
  Submit inspection reports with categorized status selection (e.g. Fan, Monitor, Antivirus)

- 📅 **Timesheet Panel**  
  Log and review periodic visit plans, view completion status (`IsDone`) based on checklist match

- 🔔 **Notification Alerts**  
  Toast notifications inform admins of upcoming inspections or unreviewed systems
## 🧪 Checklist-to-Timesheet Logic

After a checklist is saved:

- The app searches for any **existing timesheet** for that computer **within ±15 days** of the checklist date.  
- If such a timesheet exists, its `IsDone` field is automatically set to `true`.

✅ This ensures the visit is considered complete only if a relevant checklist is submitted close to the scheduled date.

---

## 🔁 Timesheet Duplication Logic

The application supports automatic generation of next-year timesheets based on a selected Persian year (e.g., 1404 → 1405):

- Every timesheet from year **1404** is cloned to **1405**  
- Each record’s `Date` is shifted by exactly **+1 Gregorian year**  
- The system checks the **currently active user** assigned to each computer and updates the `UserId` accordingly  
- If a checklist is already submitted within ±15 days of the new date, `IsDone = true` is applied

✅ This feature ensures a smooth and reliable yearly rollover of timesheet planning.

---

## 🔔 Notifications

This project uses `CommunityToolkit.WinUI.Notifications` to display native toast notifications on Windows 10/11 systems.

- 🔔 Alerts are triggered for upcoming scheduled inspections  
- ✅ Additional notifications can be configured for overdue visits, missing checklists, etc.  
- 🧩 You can fully customize the toast with app icon, expiration, sound, and click actions
## 📃 License

MIT License

Copyright (c) 2025 Kourosh Zahednia

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.


