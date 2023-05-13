// Showing Creativity
// For my program, I expanded the project and exceeded the requirements by adding the functionality
// of showing a specific "memory" from the journal to reflect on by doing a keyword search


using System;
using System.IO; 

Journal _myjournal = new Journal();

Menu _menu = new Menu(_myjournal);
_menu.Display();
