#!/bin/bash
trapctrl() {
at now + 1 minute <<END
$0 < `tty` > `tty`
END
}

trap 'trapctrl' SIGINT SIGTSTP
while true; do
    printf "WORKING!"
    sleep 1
done
