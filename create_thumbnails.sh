ffmpeg -i $1 -r 0.01 -vf scale=320:-1 $2/thumb_%05d.jpeg
