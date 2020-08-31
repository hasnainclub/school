#!/bin/bash
# this doesn't work because it is displaying the message somewhere in not 
# in the correct terminal window
at now + 1 minute <<END
echo "Hi" 
END
