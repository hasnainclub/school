#!/bin/bash
at now + 1 minute <<END
echo "I'VE EVOLVED INTO A PIKACHU!" > `tty`
sed -i "s/I'VE EVOLVED INTO A PIKACHU!/I'VE EVOLVED INTO A PIKACHU!/g" $0
END

