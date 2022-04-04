import React from 'react';
import AppBar from '@material-ui/core/AppBar';
import Toolbar from '@material-ui/core/Toolbar';
import Typography from '@material-ui/core/Typography';
import Button from '@material-ui/core/Button';
import './style.css'

function Menu() {
    return (
        <div>
            <AppBar position="static">
                <Toolbar>
                    <Typography variant="h6">
                        ByCoders
                    </Typography>
                    <div>
                        <Button color="inherit">Carregar Arquivo</Button>
                    </div>
                    <Button color="inherit">Visualizar dados</Button>
                </Toolbar>
            </AppBar>
        </div>
    )
}

export default Menu