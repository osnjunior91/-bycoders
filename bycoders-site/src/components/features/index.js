import React from 'react'
import { Grid, TextField, Button } from '@material-ui/core'
function Login() {
    return (
        <Grid
            container
            direction="column"
            justifyContent="center"
            alignItems="center"
            spacing={3}
        >
            <Grid
                item
                direction="row"
                justifyContent="center"
                alignItems="center"
            >
                <TextField fullWidth id="outlined-basic" label="Outlined" variant="outlined" />
            </Grid>
            <Grid
                item
                direction="row"
                justifyContent="center"
                alignItems="center"
            >
                <TextField fullWidth id="outlined-basic" label="Outlined" variant="outlined" />
            </Grid>
            <Grid
                item
                direction="row"
                justifyContent="center"
                alignItems="center"
            >
                <Button fullWidth variant="contained" color="primary">
                    Login
                </Button>
            </Grid>
        </Grid>
    )
}

export default Login