# Student Registration Form (Windows Forms)

A simple Student Registration Form developed using **C# Windows Forms (.NET Framework)**.

## Features

- Upload profile photo
- Browse image using OpenFileDialog
- Enter Name
- Select Date of Birth
- Select Gender
- Select Marital Status
- Select Qualification
- Choose Experience
- About Project
- Display all details using MessageBox

## Technologies Used

- C#
- Windows Forms (.NET Framework)
- Visual Studio 2026

## Screenshots

## Main Form

![Main Form](Screenshots/Mainform.jpg)

## Output

![Output](Screenshots/Output.jpg)

##  Debugging / Troubleshooting

### 1. Picture is not displayed after browsing
- Verify the selected file is a valid image (`.jpg`, `.jpeg`, `.png`, `.bmp`).
- Set the PictureBox **SizeMode** to **Zoom** or **StretchImage**.

### 2. ComboBox is empty
- Ensure the experience items are added in the `Form_Load` event.
- Verify that the `Form_Load` event is connected to the form.

### 3. Submit button does not display correct information
- Check that all control names in the code match the names in the Designer.
- Ensure the Submit button's **Click** event is assigned correctly.

### 4. Browse button is not working
- Verify that the Browse button's **Click** event is connected.
- Check that `OpenFileDialog` is implemented correctly.

### 5. Project does not run
- Build the solution (`Ctrl + Shift + B`) to check for compilation errors.
- Ensure the project is set as the **Startup Project**.
- Verify that `Application.Run(new Form1());` is present in `Program.cs`.

### 6. GitHub screenshots are not visible
- Confirm that the image filenames exactly match those referenced in `README.md`.
- Verify that the images are inside the `Screenshots` folder.
- Commit and push the image files to GitHub.

---

## Author

**Sefali**
