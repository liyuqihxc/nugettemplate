@echo off

powershell -ExecutionPolicy Bypass -NoProfile -NoLogo -Command "& \"%~dp0build.ps1\" %*; exit $LastExitCode;"
if %errorlevel% neq 0 exit /b %errorlevel%