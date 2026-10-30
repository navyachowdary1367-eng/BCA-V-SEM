<?php
$file=fopen("sample.txt","w");
if($file,"welcome to php"){
fwrite($file);
fclose($file);

echo "File created and data written successfully.";
}else{
echo "unable to create the file.";
}
?>