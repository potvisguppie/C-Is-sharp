SCHEIDER = ':'

def lees_woordenlijst():
	f = open('C:\\Users\Admin\Downloads\message (2).txt')
	woordenlijst = {}
	for line in f:
		if len(line.strip('\n').split(SCHEIDER)) == 2:
			woord1, woord2 = line.strip('\n').split(SCHEIDER)
			woordenlijst[woord1] = woord2
	f.close()
	return woordenlijst

print(lees_woordenlijst())
input('')