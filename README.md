This my solution for Lab 4 / The Capstone of Unit 2 in the 2022 C# .NET After-Hours Boot Camp at Grand Circus.

# LAB 4 / CAPSTONE: PigLatin

### Objectives: 
User Input, String Manipulation
NOTE: Points will be awarded for items that are written correctly in themselves but don’t actually work because other things are broken. There is a total of 10 points available for this lab.

### Intro: 
Pig Latin is a children’s word game in English where starting consonants are flipped to the ends of words and -ay is added to each word.  Hello World would be elloyhay orldway in Pig Latin, for instance.  Many languages have games similar to this--read more at http://mentalfloss.com/article/50242/pig-latins-11-other-languages

### Task: 
Translate from English to Pig Latin

### What will the application do?
- 1 Point: The application prompts the user for a word.
- 1 Point: The application translates the text to Pig Latin and displays it on the console.
- 1 Point: The application asks the user if he or she wants to translate another word.

### Build Specifications:
- 1 Point: Convert each word to a lowercase before translating.
- 1 Point: If a word starts with a vowel, just add “way” onto the ending.
- 2 Point: if a word starts with a consonant, move all of the consonants that appear before the first vowel to the end of the word, then add “ay” to the end of the word. 

### Additional Requirements:
- 1 Point: For answering Lab Summary when submitting to the LMS
- -2 Points: if there are any syntax errors or if the program does not run (for example, in a Main method).

### Extended Exercises (2 points maximum):
- 1 Point: Keep the case of the word, whether its uppercase (WORD), title case (Word), or lowercase (word).
- 1 Point: Allow punctuation in the input string.
- 1 Point: Translate words with contractions. Ex: can’t become an’tcay
- 1 Point: Don’t translate words that have numbers or symbols. Ex: 189 should be left as 189 and hello@grandcircus.co should be left as hello@grandcircus.co.
- 1 Point: Check that the user has actually entered text before translating.
- 1 Point: Make the application take a line instead of a single word, and then find the Pig Latin for each word in the line.

### Hints:
Treat “y” as a consonant.


### Console Preview
```
Welcome to the Pig Latin Translator!

Enter a line to be translated: {this sentence exists here}

Isthay entencesay existsway erehay

Translate another line? (y/n): N
```
