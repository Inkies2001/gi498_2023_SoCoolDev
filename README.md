# SoCool Dev GI498 Repository

A repository for a university's project under the subject GI498. This repository is contributed by group members of SoCool Dev.

## Github Repository Structure:

- Main Branches
  - Development Branch (semi-stable branch, for completed untested features)
  - master Branch (stable branch)
- Other Branches
  - Feature Branches (each feature separate branch if possible)
  - Release Branch (for each patch release)
  - Hotfixes (only fixes for master branch)


## Commit Convention:

[Symbol][System:Subsystem][Comment]

### [Symbol]:

Asterisk (*) : Shows the class of the action done by commit: any generic changes of: functionality, logic, content (majority of commits could be treated as just changing of something)

Exclamation (!) : Bug fix, or fix something. In art, in content, in code

Deash (-) : Removing of something. Removed file, removed method, removed functionality

Addition (+) : Something was added. File, feature, art asset, etc.

Tilde (~) : Tuning, polishing, adjusting, refactoring. Number was changed, configuration was adjusted, something was moved in GUI, etc. Something that doesn't affect the logic

Annoyed Emoji (-_-) : Forgot something from previous commit and we just add it in the current commit. It’s annoyed emoji


### [System:Subsystem]:

Logical area in which changes were applied ( for example, render, main menu, etc.). It could be class name, namespace or just logical part of the game. It could be omitted.


### [Comment]:

Message text, it should answer the question "what have you done."

### [Examples]:

`+` Art: Added Main Menu button image

`*` PlayerController: Changed input logic for jump

`!` Level: Falling on exit fixed [bug#1231]

## File and Code Convention

### File Sharing

- Files that are use in the project will be share via Git repository or Google Drives **ONLY**
- Files that are more than 100 MB **IS NOT ALLOWED** on Git repository. Use Google Drives for that

### File Naming

- File name must be **meaningful, no random strings/number**
- Newer version of the same file **can overwrite the older version** as long as you **inform the poeple** who are going to use them **beforehand**
- File naming must follow **snake_case** format, with the exception of C# Scripts file name which is in **PascalCase**

### Code Convention

- This project will mainly use the **C++ naming convention**
- **Class**, **Function**, and **Variable** name should be **meaningful** and show **what it is or does** on the surface. Details can be move to code comment
- **Class** and **Function** name will be in **PascalCase**
- **Variable** name will be in **camelCase**. Depends on which type of variable:
  - **Static** variable has "`s_`" prefix i.e. `s_globalTime`
  - **Member** variable has "`m_`" prefix i.e. `m_currentTime`
  - **Pointer** variable has "`p_`" prefix i.e. `p_time`
  - **Reference** variable has "`r_`" prefix i.e. `r_timeTable`
  - **Constant** variable is all CAPITALS with snake_case i.e. MAX_TIME
  - **Function Parameter** is a normal **camelCase** without any prefix
- Spelled out `private` or `public` every time you **define class, functions**, or **variables**
- Use **NaughtyAttribute** to its fullest. Use **[GroupBox]** or **[FoldOut]** to group variables together, **[InfoBox]** to show the information on the Unity Inspector without going into the code, etc. For more information refer to [this documentation](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags)
- If possible, please comment on your code using XML Documentation comment `///`. For more information, refer to [this document](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags)

## Folder Structure

Create Sub-folder for group of certain file type
- `/Scripts` for every custom C# scripts
  - Multiple scripts for a certain feature will be group together
- `/Assets` for every imported models
  - All assets used for the game will be group together, there can be more sub-folder should the need arise such as `/Assets/TileSets` or `/Assets/Portraits`
- `/ScriptableObjects` for every created scriptable object file (not the original C# that inherited ScriptableObject class)
  - Multiple scriptable objects that based on the same script will be grouped together
- `/Scenes` for every created scenes
  - HDR will generate some data for a scene. If there is one, create a sub-folder and put everythin related in the folder.
