# FxStarter
This is sort of a tiny helper tool for the awesome FxSound.
It checks for FxSound and restarts it after each login. 
This ensures that FxSound is present after hibernation 
(it tends to not come up after hibernation).
Meant to be used in a taskjob which runs at each login.

- download the exe and put it in the FXSound folder
- open 'Start'
- search for 'Task Scheduler' and open it
- open and expand the "Task Scheduler Library" branch
- open and expand the "FxSound" branch (should exist when FxSound is installed)
- create a new simple task and name it 'FxSound_WakeUp'
- task trigger: 'when I log on'
- action: 'start a program'
- path: 'C:\Program Files\FxSound LLC\FxSound\FXStarter.exe'
- done, have fun
