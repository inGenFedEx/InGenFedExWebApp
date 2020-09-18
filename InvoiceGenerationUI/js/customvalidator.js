function fncFileUpload(sender, args) {
    alert('fired');
    console.log(args);
    console.log(sender);
    if (args.Value.length < 5)
        return args.IsValid = false;
    else
        return args.IsValid = true;
}