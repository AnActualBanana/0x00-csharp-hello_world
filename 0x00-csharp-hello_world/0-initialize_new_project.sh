# Bash scrip that creates a new folder for the project, navigates to it, then makes new project.
#!/usr/bin/env bash
mkdir 0-new_project
cd 0-new_project
dotnet new console
