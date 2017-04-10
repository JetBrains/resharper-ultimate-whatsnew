// Object spread
var obj = { x: 1, y: "string" };
var newObj = { ...obj, z: 3, y: 4 }; // { x: number, y: number, z: number }
// Code completion on newObj. will give newObj.x, newObj.y, newObj.z
//newObj.

// Object rest
var foo = { x: "a", y: 5, z: 23 };
var { x, ...moo } = foo;
// Code completion on moo. will give moo.y, moo.z, but no moo.x
//moo.
