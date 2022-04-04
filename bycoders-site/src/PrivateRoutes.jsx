import React from 'react'
import { Navigate } from 'react-router-dom'

export const PrivateRoutes = ({ children }) => {
    const isAuthenticated = false;

    if (isAuthenticated) {
        return children
    }

    return <Navigate to="/" />
}