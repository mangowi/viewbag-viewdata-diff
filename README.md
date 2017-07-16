# Viewbag-Viewdata
Using ViewBag and ViewData. Have you wonder what is difference between viewBag and viewData. 

ViewBag is a wrapper around for dynamic add property on to an object on run time.

'''csharp
View.MyRunTimeProp = "This is daynmic through ViewBag"

'''
ViewBag only valid for a single request. Each time it is being reset.

ViewData
