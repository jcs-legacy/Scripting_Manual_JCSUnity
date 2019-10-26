# JCS_Sort

Sort layer for [JCS_SortingObject](?page=Interfaces_sl_JCS_SortingObject).
This will help sort the object by using the order index.


## Functions

<table>
  <tr>
    <td>AddAll</td>
    <td>All all the sort object to the sort layer.</td>
  </tr>
  <tr>
    <td>InsertionSort</td>
    <td>Use insertion sort method to sort the object.</td>
  </tr>
</table>


## Example

SortObjectExample.cs

```cs
  pubic class SortObjectExample : JCS_SortingObject {
      // Just an example class.
  }
```

Usage

```cs
  // Collect all SortObjectExample.
  SortObjectExample[] soes = parentObj.GetComponentsInChildren-<-SortObjectExample->-();

  // Create the interfaces.
  var sortExample = new JCS_Sort-<-SortObjectExample->-();

  // Add to the interface and ready to get sort.
  sortExample.AddAll(soes);

  // Do th insertion sort.
  sortExample.InsertionSort();
```
