# JCS_UnityObject

Interface handle between multiple type of Unity Engine's declare type of gameobject.
This class makes sure each gameobject will still use the same variable name.

For instance, if you want to enable/disable an gameobject. By using this interface
you do not need to know what exactly the component you are trying to enable
/disable. You can just call `GetComponent<JCS_UnityObject>().LocalEnable = true;`
instead of trying to identify the component type and change the specific variable
from its component.

## Variables

<table>
<tr>
<td>LocalType</td>
<td>Component of this current type.</td>
</tr>

<tr>
<td>LocalTransform</td>
<td>Either regular transform or recttransform base on the type.</td>
</tr>

<tr>
<td>Position</td>
<td>Position of this gameobject.</td>
</tr>

<tr>
<td>LocalPosition</td>
<td>Local position of this gameobject.</td>
</tr>

<tr>
<td>EulerAngles</td>
<td>Euler angles of this gameobject.</td>
</tr>

<tr>
<td>LocalEulerAngles</td>
<td>Local euler angles of this gameobject.</td>
</tr>

<tr>
<td>LocalScale</td>
<td>Local scale of this gameobject.</td>
</tr>

<tr>
<td>LocalEnabled</td>
<td>Enabled/disable this gameobject.</td>
</tr>

<tr>
<td>LocalColor</td>
<td>Color of this gameobject.</td>
</tr>

<tr>
<td>LocalAlpha</td>
<td>Alpha channel of this gameobject.</td>
</tr>

<tr>
<td>LocalRed</td>
<td>Red channel of this gameobject.</td>
</tr>

<tr>
<td>LocalGreen</td>
<td>Green channel of this gameobject.</td>
</tr>

<tr>
<td>LocalBlue</td>
<td>Blue channel of this gameobject.</td>
</tr>

<tr>
<td>LocalMainTexture</td>
<td>Main texture of this gameobject.</td>
</tr>

<tr>
<td>LocalSprite</td>
<td>Sprite of this gameobject.</td>
</tr>

<tr>
<td>LocalIsVisible</td>
<td>Is the gameobject visible? Or set visible.</td>
</tr>

<tr>
<td>LocalFlipX</td>
<td>Flip the gameobject in x-axis.</td>
</tr>

<tr>
<td>LocalFlipY</td>
<td>Flip the gameobject in y-axis.</td>
</tr>
</table>

## Functions

<table>
<tr>
<td>UpdateUnityData</td>
<td>Identify the object itself. See
<a href="?page=Enums_sl_JCS_UnityObjectType">
JCS_UnityObjectType
</a>
</td>
</tr>

<tr>
<td>GetObjectType</td>
<td>Returns the type of this unity object.</td>
</tr>
</table>
