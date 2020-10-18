# HepsiBurada.MarsRover
HepsiBurada.MarsRover

<h3>Code Review: Mars Rover</h3>
<h4>Part 1</h4>
<p>A squad of robotic rovers are to be landed by NASA on a plateau on Mars. This plateau, which is
curiously rectangular, must be navigated by the rovers so that their on board cameras can get a
complete view of the surrounding terrain to send back to Earth.</p>

<p>A rover's position and location is represented by a combination of x and y co-ordinates and a letter
representing one of the four cardinal compass points. The plateau is divided up into a grid to
simplify navigation. An example position might be 0, 0, N, which means the rover is in the bottom
left corner and facing North.</p>
<p>In order to control a rover, NASA sends a simple string of letters. The possible letters are 'L', 'R' and
'M'. 'L' and 'R' makes the rover spin 90 degrees left or right respectively, without moving from its
current spot. 'M' means move forward one grid point, and maintain the same heading.</p>
<p>Assume that the square directly North from (x, y) is (x, y+1).</p>
<h4>Input:</h4>
<p>The first line of input is the upper-right coordinates of the plateau, the lower-left coordinates are
assumed to be 0,0.</p>
<p>The rest of the input is information pertaining to the rovers that have been deployed. Each rover
has two lines of input. The first line gives the rover's position, and the second line is a series of
instructions telling the rover how to explore the plateau.</p>
<p>The position is made up of two integers and a letter separated by spaces, corresponding to the x
and y co-ordinates and the rover's orientation.</p>
<p>Each rover will be finished sequentially, which means that the second rover won't start to move
until the first one has finished moving.</p>
<h4>Output:</h4>
<p>The output for each rover should be its final co-ordinates and heading.</p>
<h4>Input and Output</h4>
<h4>Test Input:</h4>
<p>5 5</p>
<p>1 2 N</p>
<p>LMLMLMLMM</p>
<p>3 3 E</p>
<p>MMRMMRMRRM</p>
<h4>Expected Output:</h4>
<p>1 3 N</p>
<p>5 1 E</p>