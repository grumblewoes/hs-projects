# hs-projects
stuff I was able to recover from my C# class before my hs so ruDELY deleted my drive folder when I graduated, smh

*Most, if not all of this stuff is now outdated with XNA framework being obsolete. Monogame Pipeline can still run the files in VS Code, but some required content is missing (I evacuated the essentials since I found out my school account was getting deleted last minute), so some content files must have a placeholder to get the solution to run (images, spriteFonts, audio, etc)*

## GuessTheSong
Music quiz where media plays, and the user can select from a list of options. Also includes super basic media player functionality

## MovingWithSpeed
Simple - moving a box across the window using Xbox controller inputs

## PixelPerfectCollision
Analyzes color data of two image files in order to draw hitboxes that only cover opaque pixels. If they overlap, color changes (well really just puts a slight tint over the original image) to red to indicate collision.

## RocketCollision
Same as before, but with traditional square hitboxes.

## TypewriterText
I shamelessly stole inspiration from Undertale. The program splits the original text into substrings and lengthens the typed text based on elapsed time since the program started. By parsing the text, it is able to detect when it's time to type on a new line based on the boundaries of the rectanglular text box and the length of the word it's trying to type.

## ReactionTime
A multiplayer game using Xbox controllers. It is able to detect how many controllers are active, and adjusts the text displayed to fit the situation. A sound is played at a randomly generated time (within reason) after the game starts, and variables for each active player store how long it takes for them to give an input. Times are then displayed on screen, along with who won.
