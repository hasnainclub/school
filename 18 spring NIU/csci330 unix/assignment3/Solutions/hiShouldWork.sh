#!/bin/bash
where=$(tty)
at now + 1 minute <<END
echo "Hi" > $where
END
