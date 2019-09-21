<!--
   - $File: JCS_UndoRedoComponent.html $
   - $Date: 2018-10-01 19:35:24 $
   - $Revision: $
   - $Creator: Jen-Chieh Shen $
   - $Notice: See LICENSE.txt for modification and distribution information
   -                   Copyright © 2018 by Shen, Jen-Chieh $
-->


<div id="content-header">
  <h1>JCS_UndoRedoComponent</h1>
</div>

<p>
  Undo Redo system component.
</p>


<br/>
<h2>Variables</h2>
<br/>

<table>
  <tr>
    <td>mUndoRedoSystem</td>
    <td>
      Undo redo system, if not filled will be use the universal
      undo redo system instead.
    </td>
  </tr>
  <tr>
    <td>mFocusAfterUndo</td>
    <td>Focus component after undo.</td>
  </tr>
  <tr>
    <td>mFocusAfterRedo</td>
    <td>Focus component after redo.</td>
  </tr>
</table>


<br/>
<h2>Functions</h2>
<br/>

<table>
  <tr>
    <td>Undo</td>
    <td>Undo this component.</td>
  </tr>
  <tr>
    <td>Redo</td>
    <td>Redo this compnent.</td>
  </tr>
  <tr>
    <td>StopRecording</td>
    <td>Stop recording undo/redo.</td>
  </tr>
  <tr>
    <td>StartRecording</td>
    <td>Start recording undo/redo.</td>
  </tr>
  <tr>
    <td>IsRecording</td>
    <td>Is current component recording undo/redo action?</td>
  </tr>
  <tr>
    <td>ClearAllUndo</td>
    <td>Clear all undo history.</td>
  </tr>
  <tr>
    <td>ClearAllRedo</td>
    <td>Clear all the redo history.</td>
  </tr>
  <tr>
    <td>ClearAllUndoRedoHistory</td>
    <td>Clear all undo and redo history.</td>
  </tr>
</table>
