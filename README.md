# LinkLabelTest

Revit .NET C# external command add-in displaying a LinkLabel control in a Windows form.

In answer to
the [Revit API discussion forum](http://forums.autodesk.com/t5/revit-api/bd-p/160) thread 
on [LinkLabel not working](http://forums.autodesk.com/t5/revit-api-forum/linklabel-not-working/m-p/6766584):

**Question:** I have a form being shown inside Revit and I added a LinkLabel control but it's not being shown as a Link (it's all grey like the normal text). Also when I click on it nothing happens. I know the link is being created correctly because I tested the same code in a Windows Forms application. Does anyone know what happens with this control inside of Revit?
I read [The Building Coder](http://thebuildingcoder.typepad.com) post
on [](http://thebuildingcoder.typepad.com/blog/2015/02/from-hack-to-app-obj-mesh-import-to-directshape.html) and 
[the is post](http://thebuildingcoder.typepad.com/blog/2015/02/from-hack-to-app-obj-mesh-import-to-directshape.html) and
that person says that the LinkLabel control doesn't work for him either.
 
 **Answer:** I have no problem adding a working `LinkLabel` to a Windows Form displayed by an external Revit command.
 I just created a new add-in, added a new form to it, added a LinkLabel control to that, and implemented its `LinkClicked` event handler.


## Author

Jeremy Tammik,
[The Building Coder](http://thebuildingcoder.typepad.com) and
[The 3D Web Coder](http://the3dwebcoder.typepad.com),
[Forge](http://forge.autodesk.com) [Platform](https://developer.autodesk.com) Development,
[ADN](http://www.autodesk.com/adn)
[Open](http://www.autodesk.com/adnopen),
[Autodesk Inc.](http://www.autodesk.com).


## License

This sample is licensed under the terms of the [MIT License](http://opensource.org/licenses/MIT).
Please see the [LICENSE](LICENSE) file for full details.


