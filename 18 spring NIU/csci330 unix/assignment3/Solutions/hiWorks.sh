#!/bin/bash
at now + 1 minute <<END
echo "Hi" > `tty`
END
