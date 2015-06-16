' All scripts should be stripped of comments before being placed into the DI system...
' Unfortunately, these are stored in the database so character limits matter

'load all web page elements into memory
size = IECapture(false, 0)

'find a static value in the elements to be used as a way of linking from the 
navBase1 = IEFindValue ("Student ID:",0,false)

'Add the offset to our base element to grab the ID of the field we want
locationStudentID = navBase1 + 3

navBase2 = IEFindValue ("Primary:",0,false)
locationPrimaryName = navBase2 - 1
locationAlias1 = navBase2 + 2
locationAlias2 = navBase2 + 3
locationAlias3 = navBase2 + 6
locationAlias4 = navBase2 + 8

'Pull back the actual values from the fields on the PeopleSoft page
indexStudentID = IEGetValueByIndex(locationStudentID)
indexPrimaryName = IEGetValueByIndex(locationPrimaryName)
indexAlias1 = IEGetValueByIndex(locationAlias1)
indexAlias2 = IEGetValueByIndex(locationAlias2)
indexAlias3 = IEGetValueByIndex(locationAlias3)
indexAlias4 = IEGetValueByIndex(locationAlias4)


'Populate the dictionary values with the data (the application plan determines the rest of the mapping from here)
Field("Student ID") = indexStudentID
Field("Name") = indexPrimaryName
Field("Alias 1") = indexAlias1
Field("Alias 2") = indexAlias2
Field("Alias 3") = indexAlias3
Field("Alias 4") = indexAlias4

' debugging is useful!
'msgbox "Student ID: " & indexStudentID
'msgbox "Name: " & indexPrimaryName
'msgbox "Alias1: " & indexAlias1
'msgbox "Alias2: " & indexAlias2
'msgbox "Alias3: " & indexAlias3
'msgbox "Alias4: " & indexAlias4