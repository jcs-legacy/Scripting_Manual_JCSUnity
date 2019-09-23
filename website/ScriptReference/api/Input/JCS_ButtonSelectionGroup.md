<div id="content-header">
  <h1>JCS_ButtonSelectionGroup</h1>
</div>

<p>
  Group multiple selection and handle it so you can tell which selection is
  selected.
</p>


<br/>
<h2>Variables</h2>
<br/>

<table>
  <tr>
    <td>mOnEnableResetSelections</td>
    <td>Reset the selection when the selection is enabled.</td>
  </tr>
  <tr>
    <td>mStartingSelection</td>
    <td>
      While reseting the selections this will get choose to be the first
      selected selection.
    </td>
  </tr>
  <tr>
    <td>mSelections</td>
    <td>List of all the selections this group handle."</td>
  </tr>
</table>


<br/>
<h2>Functions</h2>
<br/>

<table>
  <tr>
    <td>AddSelection</td>
    <td>Add a selection into list.</td>
  </tr>
  <tr>
    <td>RemoveSelection</td>
    <td>Remove a selection from the list.</td>
  </tr>
  <tr>
    <td>ResetAllSelections</td>
    <td>Reset the selection group to starting status.</td>
  </tr>
  <tr>
    <td>CloseAllSelections</td>
    <td>Close the selection area. Nothing will be high-lighted.</td>
  </tr>
  <tr>
    <td>OkaySelection</td>
    <td>Run the selection button.</td>
  </tr>
  <tr>
    <td>NextSelection</td>
    <td>Change to the next button selection. (One dimensional)</td>
  </tr>
  <tr>
    <td>PrevSelection</td>
    <td>Change to the previous button selection. (One dimensional)</td>
  </tr>
  <tr>
    <td>SelectSelection</td>
    <td>Selection this selection.</td>
  </tr>
  <tr>
    <td>UpSelection</td>
    <td>Select the selection on the top. (Two Dimensional)</td>
  </tr>
  <tr>
    <td>DownSelection</td>
    <td>Select the selection on the down. (Two Dimensional)</td>
  </tr>
  <tr>
    <td>RightSelection</td>
    <td>Select the selection on the right. (Two Dimensional)</td>
  </tr>
  <tr>
    <td>LeftSelection</td>
    <td>Select the selection on the left. (Two Dimensional)</td>
  </tr>
  <tr>
    <td>GetButtonSelectionByDirection</td>
    <td>Get the selection depends on the direction.</td>
  </tr>
</table>
