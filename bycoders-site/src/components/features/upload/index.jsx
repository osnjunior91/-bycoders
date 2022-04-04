import React from 'react'
import { Grid, Button } from '@material-ui/core'
function Upload() {
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
                <input
                    accept="image/*"
                    id="contained-button-file"
                    multiple
                    type="file"
                />
            </Grid>
            <Grid
                item
                direction="row"
                justifyContent="center"
                alignItems="center"
            >
                <Button fullWidth variant="contained" color="primary">
                    Carregar Arquivo
                </Button>
            </Grid>
        </Grid>
    )
}

export default Upload