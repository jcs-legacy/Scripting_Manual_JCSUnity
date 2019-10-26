# JCS_INIFileReader

Initialize file reader, utility will read the <span class="code-inline">.ini</span> or <span class="code-inline">.properties</span> file.


## Functions

<table>
  <tr>
    <td>ReadINIFile</td>
    <td>Read the .ini file and returns it value.</td>
  </tr>
</table>


## Example

```cs
  Dictionary<string, string> data = JCS_INIFileReader.ReadINIFile(Application.dataPath + "/example.ini");

  Debug.Log(EDITOR_INI["author"]);  // Output: Author Name
  Debug.Log(EDITOR_INI["email"]);   // Output: example@email.com
```

example.ini

```cs
  author=Author Name
  email=example@email.com
```
