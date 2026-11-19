<?php
$source = "source.txt";
$destination = "destination.txt";

$sourcefile = fopen ($source,"r");
$destination = fopen ($destination,"w");

while(!feof ($sourcefile)){
$data = fgets($sourcefile);

if ($data !== false){
fwrite ($destinationfile,$data);
}
}
fclose ($sourcefile);
fclose ($destinationfile);

echo "File Copied Successfully";
?>