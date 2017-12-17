@echo off

REM Speakers (output) for this profile (see screenshots for help)
set output=""%1""

REM Microphone (input) for this profile
set input=""%2""

REM Do not edit below this line!


REM Set default sound devices in Windows
REM 	1 sets the Default Multimedia Device
REM 	2 sets the Default Communications Device
"%~dp0NIRCMDC" setdefaultsounddevice %output% 2 
"%~dp0NIRCMDC" setdefaultsounddevice %input% 2 
"%~dp0NIRCMDC" setdefaultsounddevice %output% 1 
"%~dp0NIRCMDC" setdefaultsounddevice %input% 1