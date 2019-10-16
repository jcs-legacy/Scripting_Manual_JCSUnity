<div id="content-header">
  <h1>JCS_Utility</h1>
</div>

<p>
  All code utility is stored here.
</p>

<br/>
<h2>Functions</h2>
<br/>

<table>
  <tr>
    <td>SpawnGameObject</td>
    <td>Spawn a game object.</td>
  </tr>
  <tr>
    <td>WithInRange</td>
    <td>Check if the value is within the range.</td>
  </tr>
  <tr>
    <td>WithInArrayRange</td>
    <td>Check if the index valid within the array length.&nbsp&nbsp(0 ~ (length - 1))</td>
  </tr>
  <tr>
    <td>LoopInArray</td>
    <td>Make the index is within the array length by setting the maxinum of (legnth - 1) or mininum of 0.</td>
  </tr>
  <tr>
    <td>GetImageRect</td>
    <td>Returns the size of the image.</td>
  </tr>
  <tr>
    <td>GetSpriteRendererRectWithNoScale</td>
    <td>Returns the size of the sprite renderer without the scale value multiply.</td>
  </tr>
  <tr>
    <td>GetSpriteRendererRect</td>
    <td>Returns the size of the sprite renderer.</td>
  </tr>
  <tr>
    <td>MouseOverGUI</td>
    <td>Check if the mouse is on top of a recttransform.</td>
  </tr>
  <tr>
    <td>SpawnAnimateObject</td>
    <td>Spawn a gameobject with animation attached.</td>
  </tr>
  <tr>
    <td>SpawnAnimateObjectDeathEvent</td>
    <td>Spawn a gameobject with the animator and death event on it.</td>
  </tr>
  <tr>
    <td>SetActiveToAllChildren</td>
    <td>Active all the child in a transform.</td>
  </tr>
  <tr>
    <td>MoveToTheLastChild</td>
    <td>Make the transform to the last transform of the current parent transform.</td>
  </tr>
  <tr>
    <td>SetParentWithoutLosingInfo</td>
    <td>Set the transform to another transform without losing it's info. (position, rotation, scale)</td>
  </tr>
  <tr>
    <td>AddEventTriggerEvent</td>
    <td>Add an event to EventTrigger component from Unity API.</td>
  </tr>
  <tr>
    <td>VectorDirection</td>
    <td>Returns vector direction by passing the vector direction enum.</td>
  </tr>
  <tr>
    <td>ApplyRandVector3</td>
    <td>Add random value to a vector.</td>
  </tr>
  <tr>
    <td>IsSameTribe</td>
    <td>Check if the live object is the same tribe.</td>
  </tr>
  <tr>
    <td>GetValues</td>
    <td>Get the value for each enum, use to loop through the enum.</td>
  </tr>
  <tr>
    <td>SetEnableAllComponents</td>
    <td>Set enable/disable to all component on this transform.</td>
  </tr>
  <tr>
    <td>DestroyAllTypeObjectInScene</td>
    <td>Destory all gameobjects in the scene with the type passed in.</td>
  </tr>
  <tr>
    <td>DestroyImmediateAllTypeObjectInScene</td>
    <td>Destroy all the gameobject in the scene immediately with the type passed in.</td>
  </tr>
  <tr>
    <td>FindCloneObjectsOfTypeAll</td>
    <td>Find all cloned gameobjects in the scene with the type passed in.</td>
  </tr>
  <tr>
    <td>FindNotCloneObjectsOfTypeAll</td>
    <td>Find all gameobjects that are not clones in the scene with the type passed in.</td>
  </tr>
  <tr>
    <td>FindObjectsOfTypeAllInHierarchy</td>
    <td>Find all the gameobject that are only active in the hierarchy with the type passed in.</td>
  </tr>
  <tr>
    <td>GetEasing</td>
    <td>Returns the easing function pointer base on the tweener type/enum.</td>
  </tr>
  <tr>
    <td>RemoveEmptySlot</td>
    <td>Remove the null value from a list/array.</td>
  </tr>
  <tr>
    <td>RemoveEmptySlotIncludeMissing</td>
    <td>Remove all the null value including missing reference in the list/array.</td>
  </tr>
  <tr>
    <td>GetFinalLocalEulerAngles</td>
    <td>Get the final local euler angles by accumilate all the parent gameobjects.</td>
  </tr>
  <tr>
    <td>MergeArrays</td>
    <td>Merge multiple arrays into one array.</td>
  </tr>
  <tr>
    <td>MergeArrays2</td>
    <td>Merge two array and return the new array.</td>
  </tr>
  <tr>
    <td>MergeList</td>
    <td>Merge the two lists and return the new list.</td>
  </tr>
  <tr>
    <td>CopyBtyeArray</td>
    <td>Copy byte array to another byte array memory space.</td>
  </tr>
  <tr>
    <td>EnumSize</td>
    <td>Returns the length of an enumerator.</td>
  </tr>
  <tr>
    <td>IsArrayEmpty</td>
    <td>Check if the string array is empty.</td>
  </tr>
  <tr>
    <td>ListPopFront</td>
    <td>Pop the first value from the list.</td>
  </tr>
  <tr>
    <td>ListPopBack</td>
    <td>Pop the last value from the list.</td>
  </tr>
  <tr>
    <td>IsNumberString</td>
    <td>Check if the string is a number string.</td>
  </tr>
  <tr>
    <td>DetachChildren</td>
    <td>Detach all the child from a transform.</td>
  </tr>
  <tr>
    <td>ForceDetachChildren</td>
    <td>Force detach all the child from a transform.</td>
  </tr>
  <tr>
    <td>AttachChildren</td>
    <td>Attach all the childs to this transform.</td>
  </tr>
  <tr>
    <td>ForceGetComponent</td>
    <td>Force to get a compoennt, if not found add one new then.</td>
  </tr>
  <tr>
    <td>ToJson</td>
    <td>Serialize object to JSON string.</td>
  </tr>
</table>
