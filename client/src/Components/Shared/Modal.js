import React from 'react';
import Dialog from '@mui/material/Dialog';
import DialogContent from '@mui/material/DialogContent';
import DialogTitle from '@mui/material/DialogTitle';


export const Modal = (
    {
        handleShowModal,
        open,
        children,
        modalTitle
    }) => {
    return (
        <Dialog
            open={open}
            onClose={handleShowModal}
            aria-labelledby="alert-dialog-title"
            aria-describedby="alert-dialog-description"
        >
            <DialogTitle id="alert-dialog-title">{modalTitle}</DialogTitle>
            <DialogContent style={{height: "13em", width: "20em"}}>
                {children}
            </DialogContent>
        </Dialog>
    )
}
