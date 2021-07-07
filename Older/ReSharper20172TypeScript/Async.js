var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : new P(function (resolve) { resolve(result.value); }).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
var __asyncValues = (this && this.__asyncIterator) || function (o) {
    if (!Symbol.asyncIterator) throw new TypeError("Symbol.asyncIterator is not defined.");
    var m = o[Symbol.asyncIterator];
    return m ? m.call(o) : typeof __values === "function" ? __values(o) : o[Symbol.iterator]();
};
// Async iterators
function asyncIteratorExample() {
    return __awaiter(this, void 0, void 0, function* () {
        const fetchPromises = [
            fetch('file1.txt'),
            fetch('file2.txt'),
            fetch('file3.txt')
        ];
        // Regular iterator
        for (const item of fetchPromises) {
            console.log(item); // Will log a promise
        }
        try {
            // Async iterator
            for (var fetchPromises_1 = __asyncValues(fetchPromises), fetchPromises_1_1; fetchPromises_1_1 = yield fetchPromises_1.next(), !fetchPromises_1_1.done;) {
                const item = yield fetchPromises_1_1.value;
                console.log(item); // Will log a response
            }
        }
        catch (e_1_1) { e_1 = { error: e_1_1 }; }
        finally {
            try {
                if (fetchPromises_1_1 && !fetchPromises_1_1.done && (_a = fetchPromises_1.return)) yield _a.call(fetchPromises_1);
            }
            finally { if (e_1) throw e_1.error; }
        }
        var e_1, _a;
    });
}
//# sourceMappingURL=Async.js.map