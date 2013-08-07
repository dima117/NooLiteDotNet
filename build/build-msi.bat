rd  /s /q ..\dist
rd /s /q ..\msi
nant -buildfile:main.build -D:msi.dir="..\msi2"
pause