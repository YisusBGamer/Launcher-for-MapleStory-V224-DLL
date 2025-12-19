@echo off
@echo off

:: Delete the file "v214 Official.exe" if it exists
if exist "v214 Official.exe" (
    del "v214 Official.exe"
)

:: Rename the file "temp.exe" to "v214 Official.exe" if it exists
if exist "temp.exe" (
    ren "temp.exe" "v214 Official.exe"
)

:: Start "v214 Official.exe"
start "" "v214 Official.exe"

:: Exit the batch script
exit