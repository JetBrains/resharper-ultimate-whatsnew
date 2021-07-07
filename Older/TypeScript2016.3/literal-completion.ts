// 20163 TypeScript: Literal type completion
//
// Given a type defined as a literal, provide each literal value as a completion item

function escapeDigit(d: 0|1|2|3|4|5|6|7|8|9, base) {
    // ...
}

// Invoke completion on first parameter
escapeDigit(0, 10);




function processStatus(status: "success" | "fail") {
    // ...
}

// Invoke completion inside or outside of the quotes
processStatus("fail");
