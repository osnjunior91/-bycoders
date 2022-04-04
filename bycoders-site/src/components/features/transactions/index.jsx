import React from 'react'
import { Grid, Accordion, AccordionSummary, Typography, AccordionDetails } from '@material-ui/core'
import { TableDetail } from './../../commom';

function TransactionsView() {
    return (
        <Grid
            container
            direction="column"
            justifyContent="center"
            alignItems="center"
            spacing={3}
        >
            <Accordion>
                <AccordionSummary
                    aria-controls="panel1a-content"
                    id="panel1a-header"
                >
                    <Typography>Accordion 1</Typography>
                </AccordionSummary>
                <AccordionDetails>
                    <TableDetail />
                </AccordionDetails>
            </Accordion>
            <Accordion>
                <AccordionSummary
                    aria-controls="panel2a-content"
                    id="panel2a-header"
                >
                    <Typography>Accordion 2</Typography>
                </AccordionSummary>
                <AccordionDetails>
                    <TableDetail />
                </AccordionDetails>
            </Accordion>
        </Grid>
    )
}

export default TransactionsView