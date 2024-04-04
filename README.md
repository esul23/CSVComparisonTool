# CSV Comparison Tool

# Overview
This program's only function is to allow a user to compare two different CSV files and display any rows that do not appear in the other compared file.

# Usage
- Use the browse buttons to select CSV files to compare, there must be two valid paths in order for the "Compare" button to work
- If the compared files are the same, a pop-up message will let you know
- Duplicates are taken into account, example below. "Banana" would be returned because there are two instances of it in File 2, whereas File 1 has one instance.

| File 1 Contents | File 2 Contents|
|-----------------|----------------|
|Apple|Apple|
|Orange|Orange|
|Banana|Banana|
|Grapes|Banana|
||Grapes|
