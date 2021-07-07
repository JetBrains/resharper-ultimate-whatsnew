// Async iterators
async function asyncIteratorExample() {
    const fetchPromises = [
        fetch('file1.txt'),
        fetch('file2.txt'),
        fetch('file3.txt')
    ];

    // Regular iterator
    for (const item of fetchPromises) {
        console.log(item); // Will log a promise
    }

    // Async iterator
    for await (const item of fetchPromises) {
        console.log(item); // Will log a response
    }
}