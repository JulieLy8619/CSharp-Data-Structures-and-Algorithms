## Find if a string has only unique characters
We were asked to determine if a given string contained only unique characters

## Challenge
I chose to try doing this recursively. I shorten the string each time I passed through and then called the method with that shorten string.

## Approach & Efficiency
For time, I used Big O(n) because iterate through the whole string.
For space, I used Big O(H) where H is the height of the stack because i used recursion.

## Solution
WhiteBoard: 
![SnowDayUniqueCharaWB](../../../assets/SnowDayCCUniqueCharaWB.jpg)
Console: 
![SnowDayUniqueCharaConsole](../../../assets/SnowDayCCUniqueCharaConsole.JPG)
Tests:
![SnowDayUniqueCharaTests](../../../assets/SnowDayCCUniqueCharaTests.JPG)