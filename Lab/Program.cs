using Lab007;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

XDocument xdoc = new();
XElement root = new("diagram");
Type animal = typeof(Animal);
XElement abs_class = new("abstract_class", new XAttribute("name", typeof(Animal).ToString()));
root.Add(abs_class);
foreach (MemberInfo member in animal.GetMembers(BindingFlags.Instance | BindingFlags.NonPublic 
    | BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly))
{
    abs_class.Add(new XElement(member.MemberType.ToString(), member.Name));
}
object[] animal_attributes = animal.GetCustomAttributes(false);
foreach (var attr in animal_attributes)
{
    abs_class.Add(new XElement("CustomAttribute", attr.ToString()));
}

Type cow = typeof(Cow);
XElement child_class1 = new("child_class", new XAttribute("name", typeof(Cow).ToString()));
root.Add(child_class1);
foreach (MemberInfo member in cow.GetMembers(BindingFlags.Instance | BindingFlags.NonPublic 
    | BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly))
{
    child_class1.Add(new XElement(member.MemberType.ToString(), member.Name));
}
object[] cow_attributes = cow.GetCustomAttributes(false);
foreach (var attr in cow_attributes)
{
    child_class1.Add(new XElement("CustomAttribute", attr.ToString()));
}

Type lion = typeof(Lion);
XElement child_class2 = new("child_class", new XAttribute("name", typeof(Lion).ToString()));
root.Add(child_class2);
foreach (MemberInfo member in lion.GetMembers(BindingFlags.Instance | BindingFlags.NonPublic 
    | BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly))
{
    child_class2.Add(new XElement(member.MemberType.ToString(), member.Name));
}
object[] lion_attributes = lion.GetCustomAttributes(false);
foreach (var attr in lion_attributes)
{
    child_class2.Add(new XElement("CustomAttribute", attr.ToString()));
}

Type pig = typeof(Pig);
XElement child_class3 = new("child_class", new XAttribute("name", pig.ToString()));
root.Add(child_class3);
foreach (MemberInfo member in pig.GetMembers(BindingFlags.Instance | BindingFlags.NonPublic 
    | BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly))
{
    child_class3.Add(new XElement(member.MemberType.ToString(), member.Name));
}
object[] pig_attributes = pig.GetCustomAttributes(false);
foreach (var attr in pig_attributes)
{
    child_class3.Add(new XElement("CustomAttribute", attr.ToString()));
}

Type eClassificationAnimal = typeof(eClassificationAnimal);
XElement enum_1 = new("enum", new XAttribute("name", eClassificationAnimal.ToString()));
root.Add(enum_1);
foreach (MemberInfo member in eClassificationAnimal.GetMembers(BindingFlags.Instance 
    | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly))
{
    enum_1.Add(new XElement(member.MemberType.ToString(), member.Name));
}

Type eFavouriteFood = typeof(eFavouriteFood);
XElement enum_2 = new("enum", new XAttribute("name", eFavouriteFood.ToString()));
root.Add(enum_2);
foreach (MemberInfo member in eFavouriteFood.GetMembers(BindingFlags.Instance 
    | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly))
{
    enum_2.Add(new XElement(member.MemberType.ToString(), member.Name));
}
xdoc.Add(root);

xdoc.Save("diagram.xml");