module BytesPaddings
let addPadding (bytes: byte[]) length = 
    Array.append <| Array.zeroCreate(length - bytes.Length) <| bytes
