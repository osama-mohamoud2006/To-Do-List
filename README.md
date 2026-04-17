# To-Do-List (Windows Forms)


https://github.com/user-attachments/assets/88683e2b-8b94-49e0-9ee5-4a3cf85c3049


## 1) Project Summary

`To-Do-List` is a desktop task manager built with **Windows Forms** on **.NET Framework 4.8.1**.  
It lets users:

- Add tasks with a deadline
- Mark tasks as complete/incomplete
- Remove selected tasks
- Inspect task details (name, creation time, deadline)
- Track overall completion via a progress bar

The app is intentionally minimal and UI-driven, with all task state maintained in-memory inside the main form.

---

## 2) Runtime and Entry Point

### `Program.cs`
Application startup is standard WinForms:

- `Application.EnableVisualStyles()`
- `Application.SetCompatibleTextRenderingDefault(false)`
- `Application.Run(new Form1())`

So `Form1` is the main shell and owner of the task list lifecycle.

---

## 3) Forms Overview

## `Form1` (Main Task Board)

### Primary responsibilities
- Holds task data and rendering list
- Handles add/remove/info actions
- Maintains progress calculations
- Applies visual completed-state formatting

### Controls in `Form1`

| Control Name | Type | Purpose | Key Events |
|---|---|---|---|
| `Tasks` | `CheckedListBox` | Displays all task items and checked state | `ItemCheck`, `SelectedIndexChanged` |
| `pbAdd` | `PictureBox` | Add task action icon | `Click -> Add_Click` |
| `pbRemove` | `PictureBox` | Remove selected task icon | `Click -> pbRemove_Click` |
| `pbInfo` | `PictureBox` | Show selected task details | `Click -> Info_Click` |
| `progressBar1` | `ProgressBar` | Shows completion percent | Updated in `UpdateProgress()` |
| `labProgress` | `Label` | Displays percent text (`"0%"`, etc.) | Updated in `UpdateProgress()` |
| `label1`, `label`, `label2` | `Label` | Static UI text (`Add`, `Remove`, `Info`) | None |

### Notable UI configuration
- `Tasks.Dock = Left`, so it occupies the left pane.
- Side action icons (`pbAdd`, `pbRemove`, `pbInfo`) act like command buttons.
- Progress area is anchored visually at bottom-right section.

---

## `frmAdd` (Task Input Dialog)

### Primary responsibilities
- Collect task name
- Collect task deadline
- Validate task name before submit

### Controls in `frmAdd`

| Control Name | Type | Purpose | Notes |
|---|---|---|---|
| `tbInput` | `TextBox` | Task title input | Public field accessed by `Form1` |
| `dtDeadLine` | `DateTimePicker` | Deadline picker | `MinDate = DateTime.Now` on load |
| `btnOK` | `Button` | Confirm input | Validates name and closes dialog |
| `label1`, `label2` | `Label` | Input hints | Static text |

### Form behavior
- `AcceptButton = btnOK` enables Enter key submit.
- Opens via `ShowDialog()`, making it modal.

---

## 4) Data Model and Internal State

Inside `Form1`, task data uses a private struct:

- `NameOfTask` — current display text
- `OgNameOfTask` — original text backup (used when toggling strike formatting)
- `DeadLine` — stored as formatted string (`dd/MM/yyy`)
- `CreatedWhen` — timestamp at creation (`DateTime.Now.ToString()`)
- `IsDone` — completion flag

`ToString()` is overridden to return `NameOfTask`, which is why `CheckedListBox` renders readable task titles instead of type names.

Additional runtime state in `Form1`:
- `stInfo CurrentSelected` — snapshot of selected task
- `int index` — currently selected list index

---

## 5) Feature-by-Feature Logic Walkthrough

## A) Add Task Flow

1. User clicks `pbAdd`.
2. `Add_Click` opens `frmAdd` with `ShowDialog()`.
3. On return, `Form1` reads:
   - `InputForm.tbInput.Text`
   - `InputForm.dtDeadLine.Value`
4. It assigns `CreatedWhen = DateTime.Now`.
5. If task name is empty: show error and return.
6. Else, `AddTask(stInfo)` adds item to `Tasks.Items`.
7. Progress recalculated via `UpdateProgress()`.

---

## B) Select Task Flow

`Tasks.SelectedIndexChanged`:

- Captures selected index into `index`.
- If valid (`!= -1`), copies selected item into `CurrentSelected`.

This selected snapshot is later used by info and remove actions.

---

## C) Info Flow

`Info_Click`:

1. Calls `NoThingOnListWaring()`.
2. If list is empty, shows `"List Is Empty!"`.
3. Otherwise displays a `MessageBox` with:
   - Name
   - Creation timestamp
   - Deadline

---

## D) Remove Flow

`pbRemove_Click`:

1. Calls empty-list guard (`NoThingOnListWaring()`).
2. If at least one item exists and a valid selection is available (`index != -1`):
   - Removes `Tasks.Items[index]`
   - Calls `UpdateProgress()`.

---

## E) Complete / Uncomplete Flow

`Tasks_ItemCheck` toggles done state and visual formatting.

- Reads selected task struct from list.
- If not done:
  - Stores original text in `OgNameOfTask`
  - Applies strike-like styling using Unicode combining char `\u0336`
  - Sets `IsDone = true`
- Else:
  - Restores `NameOfTask = OgNameOfTask`
  - Sets `IsDone = false`
- Writes modified struct back to list item.
- Calls `UpdateProgress()`.

---

## 6) Progress Engine

`UpdateProgress()` recalculates completion from current list contents:

- Resets progress to `0`
- Computes per-task contribution using integer division:
  - `TheValOfEachTask = 100 / Tasks.Items.Count`
- Adds contribution for each item where `IsDone == true`
- Caps at `progressBar1.Maximum` to avoid overflow
- Includes a correction rule:
  - if progress hits `99`, force to `100`  
  (handles rounding artifacts like `100/3 = 33`)

`labProgress` mirrors the current progress bar value with `%`.

---

## 7) Validation and Defensive Checks

- Empty task name is blocked in both:
  - `frmAdd.btnOK_Click`
  - `Form1.Add_Click` (second safety check)
- Empty list operations are prevented with `NoThingOnListWaring()`.
- Remove requires a valid selected index.

---

## 8) UX and Visual Design Notes

- Action icons (`plus`, `delete`, `info`) are loaded from project resources.
- Completed tasks are visually altered with generated strike text, not font styles.
- App uses immediate feedback (`MessageBox`) for invalid operations.

---

## 9) File Map

- `Program.cs` — app bootstrap
- `Form1.cs` — core logic and task state
- `Form1.Designer.cs` — main form layout/control wiring
- `frmAdd.cs` — add dialog behavior and validation
- `frmAdd.Designer.cs` — add dialog layout/control wiring
