<div id="content-header">
  <h1>JCS_INIFileReader</h1>
</div>

<p>
  Initialize file reader, utility will read the <span class="code-inline">.ini</span> or <span class="code-inline">.properties</span> file.
</p>


<br/>
<h2>Functions</h2>
<br/>

<table>
  <tr>
    <td>ReadINIFile</td>
    <td>Read the .ini file and returns it value.</td>
  </tr>
</table>


<br/>
<h2>Example</h2>
<br/>

<div class="code-block">
  Dictionary<string, string> data = JCS_INIFileReader.ReadINIFile(Application.dataPath + "/example.ini");

  Debug.Log(EDITOR_INI["author"]);  // Output: Author Name
  Debug.Log(EDITOR_INI["email"]);   // Output: example@email.com

</div>

<br/>
<p>example.ini</p>

<div class="code-block">
  author=Author Name
  email=example@email.com

</div>
