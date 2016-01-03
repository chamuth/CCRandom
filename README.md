# CCRandom
A new Random Engine for your Applications

In the developent of games (2D, 3D or NoGUI), people need a way to generate a number, choose a random string from input, choose a random integer from input. CCRandom is an updated version for generating <b>"Randoms"</b>. Basically it is different from the Random found in .NET Framework. This project is for anyone who would like to join us.<br>
The basic concept of this code is to generate numbers using the Computers TickCount ran by the CMOS memory. It's the basic way of developing a <b>Random Number</b>. <b>(Don't forget that the Environment.TickCount has been forced for many arithmetic operations and the result is your Random Number)</b>. <br><br>
The basic algorithm of this concept is:
``` 
tick_rev = (int)((((tick_rev) * (int)(tick_revv / 3.14)) % 8192) * 11915.1);
```
